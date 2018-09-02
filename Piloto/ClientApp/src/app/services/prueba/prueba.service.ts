import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPersona } from '../../prueba/Personas';
import { Observable } from 'rxjs';

@Injectable()
export class PruebaService {

  private urlApi = this.baseUrl + "api/Prueba";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getPersonas(): Observable<IPersona[]> {
    return this.http.get<IPersona[]>(this.urlApi);
  }

}
