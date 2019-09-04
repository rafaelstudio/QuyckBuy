import { Component } from "@angular/core"
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls:["./login.component.css"]
})
export class LoginComponent {
   

  public usuario;
  public usuarioAltenticado: boolean;

  constructor() {
    this.usuario = new Usuario();
  }

  entrar(): void {
    if (this.usuario.email == "rafa@teste.com" && this.usuario.senha == "1234") {
      this.usuarioAltenticado = true;
    }
  }

}
