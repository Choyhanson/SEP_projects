import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Login } from 'src/app/shared/models/login';
import { User } from 'src/app/shared/models/user';
import { environment } from 'src/environments/environment';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  private currentUserSubject=new BehaviorSubject<User>({} as User);
  public currentUser=this.currentUserSubject.asObservable();

  private isLoginSubject=new BehaviorSubject<boolean>(false);
  public isLogin=this.isLoginSubject.asObservable();

  private jwtHelper = new JwtHelperService();

  constructor(private http: HttpClient) { }

  login(user: Login): Observable<boolean> {
    // take email/password from login component and post it to api/account/login URL
    // if we get 200 OK status from API, email/password is correct, so we get token from API
    // store the token in localstorage
    // return true to component

    return this.http.post(`${environment.apiUrl}account/login`, user).pipe(map((response: any) => {
      if (response) {
        localStorage.setItem('token', response.token);
        // create the observables so that other components can get notification when user successfully login
        // any component can subscribe to this obserables to get the notification
        this.populateUserInfo();
        return true;
      }
      return false;
    }
    ));
  }

  populateUserInfo() {
    var token = localStorage.getItem('token');
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      const decodeToken = this.jwtHelper.decodeToken(token);
      this.currentUserSubject.next(decodeToken);
      this.isLoginSubject.next(true);
    }

  }

  logout() {
    // remove the token from local storage

    localStorage.removeItem('token');
    this.currentUserSubject.next({} as User);
    this.isLoginSubject.next(false);
  }

  register(){
    // take the user registration info model ( firstName, lastName, dateOfBirth, email, password )
    // post it to api/account
    // if success, redirect to login route 

  }
}
