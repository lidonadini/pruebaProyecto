import { Component } from '@angular/core';

@Component({ // un componente no es mas que una clase unida con un template
  selector: 'app-root',
  templateUrl: './app.component.html',// template que se le asocia al componente
  styleUrls: ['./app.component.css']
})
export class AppComponent { // la clase asociada al componente implica funcionalidades 
  title = 'app'; // aqui se pueden colocar propiedades y funciones que pueden ser llamadas desde el app.component.html
  // es decir, desde el template de html del componente

}
