function building(params) {
  let floorCount = Number(params.shift());
  let apartmentPerFloor = Number(params.shift());

  for (let f = floorCount; f >0; f--) {
    let currentFloor = "";
    for (let a = 0; a < apartmentPerFloor; a++) {
      if (f == floorCount) {
        currentFloor += `L${f}${a} `;
        continue;
      }
      if (f % 2 == 0) {
        currentFloor += `O${f}${a} `;
      } else {
        currentFloor += `A${f}${a} `;
      }
    }
    console.log(currentFloor);
  }
}
building(["4", "4"]);
