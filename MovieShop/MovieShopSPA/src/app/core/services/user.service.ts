import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Favorite } from 'src/app/shared/models/favorite';
import { Purchase } from 'src/app/shared/models/purchase';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpClient) { }

  getUserPurchases():Observable<Purchase[]>{
    return this.http.get<Purchase[]>(`${environment.apiUrl}User/purchases`);
  }

  getUserFavorites():Observable<Favorite[]>{
    return this.http.get<Favorite[]>(`${environment.apiUrl}User/favorites`);
  }
}
