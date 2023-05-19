function bday(params) {
  let width = Number(params.shift());
  let length = Number(params.shift());

  let cakePieces = width * length;

  while (cakePieces > 0) {
    let cmd = params.shift();
    let takenPieces = Number(cmd);
    let stop = String(cmd);
    if (!isNaN(takenPieces)) {
      cakePieces -= takenPieces;
    } else if (stop === "STOP") {
      console.log(`${cakePieces} pieces are left.`);
      return;
    }
  }
  console.log(
    `No more cake left! You need ${Math.abs(cakePieces)} pieces more.`
  );
}
bday(["10", "2", "2", "4", "6", "STOP"]);
