export class Person {
    constructor(_id, _name) {
        this.ID = _id;
        this.Name = _name;
    }
    Print() {
        return `Id = ${this.ID} , Name = ${this.Name}`;
    }
}