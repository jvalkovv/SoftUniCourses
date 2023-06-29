function cityTaxes(name, population, treasury) {
  let city = {
    name,
    population,
    treasury,
    taxRate: 10,
    collectTaxes() {
      this.treasury += Math.ceil(this.population * this.taxRate);
    },
    applyGrowth(percent) {
      this.population += Math.ceil((this.population * percent) / 100);
    },
    applyRecession(percent) {
      this.treasury -= Math.ceil((this.treasury * percent) / 100);
    },
  };
  return city;
}

const city = cityTaxes("Tortuga", 7000, 15000);
city.collectTaxes();
console.log(city.treasury);
city.applyGrowth(5);
console.log(city.population);
