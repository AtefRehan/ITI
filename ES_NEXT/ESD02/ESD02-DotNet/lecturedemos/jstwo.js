//abdelrahman
import human, { namesarr, fname as nasrfirstname } from './jsone.js';
/*import humanhamada, { namees } from './jshamada.js';*/
let fname = "Abd Elrahman";
// logic depending on nasr code
// print array namesarr which allocated in jsone.js(which written by nasr)


namesarr.forEach((fname) => { console.log(`Name = ${fname}`); });
console.log(`abd el rahaman fname ${fname}`);
console.log(`Nasr fname ${nasrfirstname}`);
let aliperson = new human(100, "Ali ibraheem");
console.log(aliperson.Print());
// export , import 