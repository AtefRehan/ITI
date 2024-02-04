// let username = "myname";
// let userage = "26";
// let gender = "male";
// let color = "red";

// document.cookie = "username=" + username;
// document.cookie = "userage=" + userage;
// document.cookie = "gender=" + gender;
// document.cookie = "color=" + color;




function saveLocalStorage() {
  let username = document.getElementById("name").value;

  localStorage.setItem("name", username);

  let age = document.getElementById("age").value;

  localStorage.setItem("age", age);

  let gender = document.getElementById("gender").value;
  localStorage.setItem("gender", gender);
  // let color = document.getElementById("color").value;
}


// let genderInCookie = document.cookie.split(";")[2].split("=")[1];
// if (genderInCookie == "male") {

//   document.querySelectorAll("input[type=radio]")[0].setAttribute('checked', 'true');
// } else {
//   document.querySelectorAll("input[type=radio]")[1].setAttribute ("checked,true");
// }

// var options = document.querySelectorAll("select > option")
// options.forEach(option => {
//     if(option.value==document.cookie.split(";")[3].split('=')[1]){
//         option.setAttribute('selected','true');
//     }else{return;}

// });
