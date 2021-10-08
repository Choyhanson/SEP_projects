import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { MovieCard } from 'src/app/shared/models/movieCard';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import{Movie} from 'src/app/shared/models/movie';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  constructor(private http: HttpClient) { }

  // Home Component =>
  getTopGrossingMovies(): Observable<MovieCard[]> {

    // Always Angular services return Observables

    // return this.http.get<MovieCard[]>('https://localhost:44354/api/Movies/toprevenue');
    return this.http.get<MovieCard[]>(`${environment.apiUrl}movies/toprevenue`);
    // return this.http.get('https://localhost:44354/api/Movies/toprevenue').pipe(map(resp => resp as MovieCard[]));

    // rxjs as js LINQ
    // map in JS RXJS => Select
    // Where => filter
  }
  getMovieDetails(id: number):Observable<Movie> {
    // call API methods
    return this.http.get<Movie>(`${environment.apiUrl}movies/${id}`);
  }
}
