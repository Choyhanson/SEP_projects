import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Genre, GenreElement } from 'src/app/shared/models/genre';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private http: HttpClient) { }


  
  getAllGenres(): Observable<GenreElement[]> {
    return this.http.get<GenreElement[]>(`${environment.apiUrl}movies/genres`);
  }
  getAllMoviesByGenre(genreId:number,page:number=1):Observable<Genre>{
    return this.http.get<Genre>(`${environment.apiUrl}movies/genre/${genreId}/Page=${page}`);
  }
}
