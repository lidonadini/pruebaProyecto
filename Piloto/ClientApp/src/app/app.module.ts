import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { PruebaComponent } from './prueba/prueba.component';

@NgModule({ // en el NgModule se deben crear todos los componentes de la applicacion
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    PruebaComponent
  ],
  imports: [ // son immportaciones que necesita el module para funcionar
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }), // sirve para qye pueda trabajar con angulat
    HttpClientModule, // se utiliza para comunicarse con la API
    FormsModule,
    RouterModule.forRoot([ // este componente es la tabla de configuracion para el componente menu 
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },// si en la url esta fetch-data entonces mostrara el
      { path: 'Prueba', component: PruebaComponent },
      // el componente FetchDataComponet
    ])
  ],
  providers: [], // aca se colocan los servicios que podemos inyectar en las clases o componentes
                 // un servicio no es mas que una clase que podemos reutilizar en varias partes de la app
  bootstrap: [AppComponent] // Esto quiere decir que el componente AppComponent debe ser el primero en ser cargado
                            // en la pagina
})
export class AppModule { }
