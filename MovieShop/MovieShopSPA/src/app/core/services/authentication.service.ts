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

  private currentUserInfo=new BehaviorSubject<User>({} as User);
  public currentUser=this.currentUserInfo.asObservable();

  private isLoginStatus=new BehaviorSubject<boolean>(false);
  public isLogin=this.isLoginStatus.asObservable();

  private jwtHelper = new JwtHelperService();

  constructor(private http: HttpClient) { }

  login(user: Login): Observable<boolean> {
    return this.http.post(`${environment.apiUrl}account/login`, user).pipe(map((response: any) => {
      if (response) {
        localStorage.setItem('token', response.token);
        this.userInfo();
        return true;
      }
      return false;
    }
    ));
  }

  userInfo() {
    var token = localStorage.getItem('token');
    if (token ) {
      const decodeToken = this.jwtHelper.decodeToken(token);
      this.currentUserInfo.next(decodeToken);
      this.isLoginStatus.next(true);
    }

  }

  logout() {
    localStorage.removeItem('token');
    this.currentUserInfo.next({} as User);
    this.isLoginStatus.next(false);
  }
}
