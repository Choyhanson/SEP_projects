import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Favorite } from 'src/app/shared/models/favorite';
import { Purchase } from 'src/app/shared/models/purchase';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private _headers = new HttpHeaders().append('responseType','json');

  constructor(private http:HttpClient) { 
  }

  getUserPurchases():Observable<Purchase[]>{
    return this.http.get<Purchase[]>(`${environment.apiUrl}User/purchases`);
  }

  isPurchased(movieId:number):Observable<boolean>{
    return this.http.get(`${environment.apiUrl}user/isPurchased/${movieId}`)
    .pipe(map((response:any)=>{
      if(response.status){
        return true;
      }
      return false;
    }));
  }
  addPurchase(movieId:number,price:number):Observable<boolean>{
    return this.http.post(`${environment.apiUrl}user/addPurchase/${movieId}/${price}`,{headers:this._headers})
    .pipe(map((response:any )=>{
      if(response.res){
        return true;
      }
      return false;
    }));
  }

  getUserFavorites():Observable<Favorite[]>{
    return this.http.get<Favorite[]>(`${environment.apiUrl}User/favorites`);
  }

  isFavorited(movieId:number):Observable<boolean>{
    return this.http.get<boolean>(`${environment.apiUrl}user/isFavorited/${movieId}`);
  }

  addFavorite(movieId:number):Observable<boolean>{
    return this.http.post(`${environment.apiUrl}user/addFavorite/${movieId}`,{headers:this._headers})
    .pipe(map((response:any)=>{
      if(response.favorite){
        return true;
      }
      return false;
    }));
  }

  removeFavorite(movieId:number):Observable<boolean>{
    return this.http.delete(`${environment.apiUrl}user/removeFavorite/${movieId}`,{headers:this._headers})
    .pipe(map((response:any)=>{
      if(response){
        return true;
      }
      return false;
    }));
  }
}
