// create array of student , employee
//import { Student } from './Student.js';
//import { Employee } from './Employee.js';


import itistudent from './Student.js';
import  itiemployee  from './Employee.js';

let stdone = new itistudent(1000, "Student Name",44);

let emponeone = new itiemployee(5000, "Employee Name", 1200);

let staff = [stdone, emponeone];
staff.forEach((s) => { console.log(s.Print()); });