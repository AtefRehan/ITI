import { Shape } from "./shape.js";
export class Triangle extends Shape {
  #base;
  #height;

  constructor(base, height) {
    super();
    this.#height = height;
    this.#base = base;
  }
  calcArea() {
    return "Triangle area is "+ 0.5 * (this.#base * this.#height);
  }

 
  
}
