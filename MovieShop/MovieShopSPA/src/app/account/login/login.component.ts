import { HttpErrorResponse, HttpResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/core/services/authentication.service';
import { Login } from 'src/app/shared/models/login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {


  user: Login = {
    email: '',
    password: '',
  }

  constructor(private authService: AuthenticationService, private router: Router) { }

  ngOnInit(): void {

  }

  loginSubmit(form: NgForm) {
    // capture the email/password from the view
    this.user.email = form.value.email;
    this.user.password = form.value.password;
    this.authService.login(this.user).subscribe(
      data => {
        this.router.navigate(['/']);
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    )
  }
}
