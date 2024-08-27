variable "resource_group_name" {
  type        = string
  description = "Resource group name in Azure"
}
variable "resource_group_location" {
  type        = string
  description = "Resource group location in Azure"
}

variable "azurerm_service_plan_name" {
  type        = string
  description = "Service plan name in Azure"
}

variable "azurerm_service_app_name" {
  type        = string
  description = "Service application name in Azure"
}

variable "azurerm_sql_server_name" {
  type        = string
  description = "SQL Server name in Azure"
}

variable "azurerm_sql_database_name" {
  type        = string
  description = "SQL Server DATABASE name in Azure"
}

variable "azurerm_sql_admin_login" {
  type        = string
  description = "Admin user name for login in DB"
}
variable "azurerm_sql_admin_password" {
  type        = string
  description = "Admin user password for login in DB"
}
variable "azurerm_mssql_firewall_rule" {
  type        = string
  description = "Admin user password for login in DB"
}
variable "azurerm_github_url" {
  type        = string
  description = "Connection github url"
}
variable "azurerm_github_branch" {
  type        = string
  description = "Github project branch"
}

