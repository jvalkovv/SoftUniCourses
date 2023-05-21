function password(input) {
  let validPassword = "s3cr3t!P@ssw0rd";

  let inputPassword = input[0];

   if(inputPassword!==validPassword)
   {
    console.log("Wrong password!")
   }
   else{
    console.log("Welcome")
   }

}
password(["s3cr3t!P@ssw0rd"]);
