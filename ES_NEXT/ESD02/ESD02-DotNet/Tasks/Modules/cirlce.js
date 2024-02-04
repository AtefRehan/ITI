import { Shape } from "./shape.js";
export class Circle extends Shape {
#radius ;
constructor(radius){
    super();
    this.#radius = radius;
}

    calcArea() {
        return "circle area is "+Math.PI*this.#radius*this.#radius;
    }
}