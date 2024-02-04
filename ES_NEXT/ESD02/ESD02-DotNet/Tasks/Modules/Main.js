import { Rectangle } from "./rectangle.js";
import { Circle } from "./cirlce.js";
import { Triangle } from "./triangle.js";

let arrayOfShapes = [new Circle(5), new Triangle(5, 10), new Rectangle(10, 20)];

arrayOfShapes.forEach((shape) => {
  console.log(shape.calcArea());
});
