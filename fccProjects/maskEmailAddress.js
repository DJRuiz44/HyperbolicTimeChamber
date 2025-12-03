let email = "djruiz@gmail.com";

const maskEmail = email => {
  let masked = email.slice(1, email.indexOf("@") - 1);
  console.log(masked);
  let maskedEmail = email[0];
  for(let i=0; i<masked.length; i++){
    maskedEmail += "*";
  }
  maskedEmail += email.slice(email.indexOf("@") - 1);
  console.log(maskedEmail);
  return maskedEmail;
}
console.log(maskEmail("djruiz@gmail.com"));
maskEmail("apple.pie@example.com");
console.log(maskEmail(email));