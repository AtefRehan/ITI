import { Person } from './Person.js';
export default class Employee extends Person {
    constructor(_id, _name, _salary) {
        // this.ID=
        super(_id, _name);
        this.Salary = _salary;
    }
    Print() {
        return `${super.Print()} , Salary = ${this.Salary}`;
    }
}