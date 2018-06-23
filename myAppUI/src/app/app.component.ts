import { Component, OnInit } from '@angular/core';
import { JwtHelper } from 'angular2-jwt';
import { AuthService } from './_services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent  implements OnInit {

  constructor(private authService: AuthService){}
  title = 'app';
  jwtHelper: JwtHelper = new JwtHelper();
  ngOnInit() {
  const token = localStorage.getItem('token');
  if (token) {
    this.authService.decodedToken = this.jwtHelper.decodeToken(token);
  }
  }
}
