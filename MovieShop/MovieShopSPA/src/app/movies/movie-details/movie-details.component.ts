import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie } from 'src/app/shared/models/movie';
import { MoviesService } from 'src/app/core/services/movies.service';



@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {

  id: number = 0;
  movie!: Movie;
  constructor(private route: ActivatedRoute, private moviesService: MoviesService) { }

  ngOnInit(): void {
    // get the id from the URL
    // read the id from UR: and go to MovieService, create getMovieDetails method => Observable<Movie>
    this.route.paramMap.subscribe(
      p => {
            this.id = Number(p.get('id'));
            console.log('Movie Id from the URL:' + this.id);
    // call the MovieService to get the movie info
    this.moviesService.getMovieDetails(this.id)
      .subscribe(
        m => {
          this.movie=m;
        }
      )
    })
    
  }

}
