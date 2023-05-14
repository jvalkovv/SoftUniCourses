function salary(params) {
  let openTabCount = Number(params[0]);
  let salary = Number(params[1]);

  for (let index = 1; index <= openTabCount; index++) {
    let currTab = String(params[index]);

    if (currTab === "Facebook") {
      salary -= 150;
    } else if (currTab === "Instagram") {
      salary -= 100;
    } else if (currTab === "Reddit") {
      salary -= 50;
    }
    if (salary <= 0) {
      console.log("You have lost your salary.");
      return;
    }
  }
  console.log(`${salary}`);
}
salary([
  "10",
  "750",
  "Facebook",
  "Dev.bg",
  "Instagram",
  "Facebook",
  "Reddit",
  "Facebook",
  "Facebook",
]);
