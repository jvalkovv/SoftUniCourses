# Configure the Azure provider
terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 3.52.0"
    }
  }
}

provider "azurerm" {
  features {}
}

# Create the resource group
resource "azurerm_resource_group" "rg" {
  name     = var.resource_group_name
  location = var.resource_group_location
}

# Create the Linux App Service Plan
resource "azurerm_service_plan" "asp" {
  name                = var.azurerm_service_plan_name
  location            = var.resource_group_location
  resource_group_name = var.resource_group_name
  os_type             = "Linux"
  sku_name            = "F1"
}

# Create the web app, pass in the App Service Plan ID
resource "azurerm_linux_web_app" "lwa" {
  name                = var.azurerm_service_app_name
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  service_plan_id     = azurerm_service_plan.asp.id

  connection_string {
    name  = "DefaultConnection"
    type  = "SQLAzure"
    value = "Data Source=tcp:${azurerm_mssql_server.mssql.fully_qualified_domain_name},1433;Initial Catalog=${azurerm_mssql_database.mssqldb.name};User ID=${azurerm_mssql_server.mssql.administrator_login};Password=${azurerm_mssql_server.mssql.administrator_login_password};Trusted_Connection=False; MultipleActiveResultSets=True;"
  }

  site_config {
    application_stack {
      dotnet_version = "6.0"
    }
    always_on = false
  }
}

# Create SQL Server
resource "azurerm_mssql_server" "mssql" {
  name                         = var.azurerm_sql_server_name
  location                     = var.resource_group_location
  resource_group_name          = var.resource_group_name
  version                      = "12.0"
  administrator_login          = var.azurerm_sql_admin_login
  administrator_login_password = var.azurerm_sql_admin_password
}

# Create MSSQL Database 
resource "azurerm_mssql_database" "mssqldb" {
  name           = var.azurerm_sql_database_name
  server_id      = azurerm_mssql_server.mssql.id
  collation      = "SQL_Latin1_General_CP1_CI_AS"
  license_type   = "LicenseIncluded"
  max_size_gb    = 2
  sku_name       = "S0"
  zone_redundant = false
  depends_on     = [azurerm_mssql_server.mssql]

}

# Create Firewall Rule
resource "azurerm_mssql_firewall_rule" "mfr" {
  name             = var.azurerm_mssql_firewall_rule
  server_id        = azurerm_mssql_server.mssql.id
  start_ip_address = "0.0.0.0"
  end_ip_address   = "0.0.0.0"
}

#  Deploy code from a public GitHub repo
resource "azurerm_app_service_source_control" "sourcecontrol" {
  app_id                 = azurerm_linux_web_app.lwa.id
  repo_url               = var.azurerm_github_url
  branch                 = var.azurerm_github_branch
  use_manual_integration = true
}
