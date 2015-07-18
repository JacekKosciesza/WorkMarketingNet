/// <reference path="typings/angular2/angular2.d.ts" />

// compile using: tsc -m commonjs -t es5 --emitDecoratorMetadata app.ts

import {Component, View, bootstrap, NgFor} from 'angular2/angular2';

// Annotation section
@Component({
  selector: 'my-app'
})
@View({
  template: `
  <h1>Hello {{ name }}</h1>
  <p>Friends:</p>
  <ul>
     <li *ng-for="#name of names">
        {{ name }}
     </li>
  </ul>
  `,
  directives: [NgFor]
})
// Component controller
class MyAppComponent {
  name: string;
  names: Array<string>;
  
  constructor() {
    this.name = 'Alice';
    this.names = ["Aarav", "Martín", "Shannon", "Ariana", "Kai"];
  }
}
bootstrap(MyAppComponent);