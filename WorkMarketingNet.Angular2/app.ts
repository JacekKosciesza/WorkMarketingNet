/// <reference path="typings/angular2/angular2.d.ts" />

// compile using: tsc -m commonjs -t es5 --emitDecoratorMetadata app.ts

import {Component, View, bootstrap} from 'angular2/angular2';

// Annotation section
@Component({
  selector: 'my-app'
})
@View({
  template: '<h1>Hello {{ name }}</h1>'
})
// Component controller
class MyAppComponent {
  name: string;
  
  constructor() {
    this.name = 'Alice';
  }
}
bootstrap(MyAppComponent);