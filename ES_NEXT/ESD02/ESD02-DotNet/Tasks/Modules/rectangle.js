import { Shape } from "./shape.js";
export class Rectangle extends Shape {

#width;
#height;

constructor(width, height) {
    super();
    this.#width = width;
    this.#height = height;

}
calcArea() {
    return "rectangle area is "+ this.#width * this.#height;
}

}
