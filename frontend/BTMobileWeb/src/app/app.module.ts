import { ClienteService } from './cliente.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { Ficha_Listar } from './ficha/listar/listar.component';
import { Ficha_Editar } from './ficha/editar/editar.component';
import { Ficha_AlterarCarga } from './ficha/alterar-carga/alterar-carga.component';
import { Cliente_Listar } from './cliente/listar/listar.component';
import { Cliente_Detalhe } from './cliente/detalhe/detalhe.component';
import { SerieFichaComponent } from './ficha/serie-ficha/serie-ficha.component';

import { FichaService } from './ficha.service';

import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';


const appRoutes: Routes = [
  //{ path: 'ficha', component: ListarComponent }
  { path: '', component: Ficha_Listar },
  { path: 'ficha/:id', component: Ficha_Editar},
  { path: 'exercicioSerie', component: Ficha_AlterarCarga},
  { path: 'cliente', component: Cliente_Listar},
  { path: 'cliente/:id', component: Cliente_Detalhe},
  { path: 'serieFicha/:fichaId', component: Cliente_Detalhe}
]

@NgModule({
  declarations: [
    AppComponent,
    Ficha_Listar,
    Ficha_Editar,
    Ficha_AlterarCarga,
    Cliente_Listar,
    Cliente_Detalhe,
    SerieFichaComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [
    FichaService,
    ClienteService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
