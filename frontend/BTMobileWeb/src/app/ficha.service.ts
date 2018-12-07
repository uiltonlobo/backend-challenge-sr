import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class FichaService {
  
  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:44362/api';
  
  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  public getProfessores() {
    return this.http.get(this.accessPointUrl + "/professor", { headers: this.headers });
  }

  public getClientes() {
    return this.http.get(this.accessPointUrl + "/cliente", { headers: this.headers });
  }

  public getFichas(professorId: number, clienteId: number) {
    return this.http.get(this.accessPointUrl + "/ficha?professorId=" + professorId + "&clienteId=" + clienteId, { headers: this.headers});
  }

  public getFicha(id: number) {
    return this.http.get(this.accessPointUrl + "/ficha/" + id, {headers: this.headers});
  }
  
  public alterarCarga(fichaId: number, clienteId: number, exercicioSerieId: number, novaCarga: number) {
    
    let parametros = {
      FichaId: fichaId,
      ClienteId: clienteId,
      ExercicioSerieId: exercicioSerieId,
      ValorCarga: novaCarga
    }

    let url:string = this.accessPointUrl + "/exercicioserie/" + fichaId;

    return this.http
      .put(url, parametros, {headers: this.headers})
      .subscribe(
          data => { console.log("PUT Request is successful ", data); },
          error => { console.log("Rrror", error); }
    )  ;
  }
  
}