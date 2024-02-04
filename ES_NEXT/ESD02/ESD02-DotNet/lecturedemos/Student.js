import { Person } from './Person.js';
export default class Student extends Person {
    constructor(_id, _name, _intake) {
        // this.ID=
        super(_id, _name);
        this.Intake = _intake;
    }
    Print() {
        return `${super.Print()} , Intake = ${this.Intake}`;
    }
}