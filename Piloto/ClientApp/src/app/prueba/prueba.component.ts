import { Component, OnInit } from '@angular/core';
import { IPersona } from './Personas';
import { PruebaService } from '../services/prueba/prueba.service';

@Component({
  selector: 'app-prueba',
  templateUrl: './prueba.component.html',
  styleUrls: ['./prueba.component.css']
})
export class PruebaComponent implements OnInit {

  personas: IPersona[];

  constructor(private personasService: PruebaService) { }

  ngOnInit() {
    this.personasService.getPersonas().subscribe(personasdelWS => this.personas = personasdelWS);
  }

}
