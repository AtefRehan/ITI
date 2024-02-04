// nasr
export let fname = "Nasr";
export let namesarr = ["ali", "mohamed", "ibraheem"];
export default class Person {
    constructor(_id, _name) {
        this.ID = _id;
        this.Name = _name;
    }
    Print() {
        return `ID = ${this.ID} , Name = ${this.Name}`;
    }
}//end of person
export function Sum(x, y) {
    return x + y;
}
function Sub(x, y) {
    return Math.abs(x - y);
}
