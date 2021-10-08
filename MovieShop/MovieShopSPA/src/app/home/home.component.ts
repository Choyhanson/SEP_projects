import { Component, OnInit } from '@angular/core';
import { MoviesService } from '../core/services/movies.service';
import { MovieCard } from '../shared/models/movieCard';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  movieCards!:MovieCard[];

  constructor(private moviesService: MoviesService) { }

  ngOnInit(): void {
    // use to call our API
    this.moviesService.getTopGrossingMovies()
    .subscribe(
      m => {
      this.movieCards=m;
      // console.table(this.movieCards);
      }
    )
  }

}

// Angular Life Cycle Hooks