function tiles(person) {
  let age = Number(person[0]);
  let gender = String(person[1]);

  if (gender === "m" && age >= 16) {
    console.log("Mr.");
  } else if (gender === "m" && age < 16) {
    console.log("Master");
  }
  else if(gender==="f" && age >=16)
  {
    console.log("Ms.");
  }
  else if(gender==="f"&& age < 16)
  {
    console.log("Miss");
  }
}
