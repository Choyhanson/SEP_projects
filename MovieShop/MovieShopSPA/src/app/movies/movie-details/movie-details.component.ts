import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Movie } from 'src/app/shared/models/movie';
import { MoviesService } from 'src/app/core/services/movies.service';
import { AuthenticationService } from 'src/app/core/services/authentication.service';
import { UserService } from 'src/app/core/services/user.service';



@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {

  id: number = 0;
  movie!: Movie;
  isPurchased: boolean = false;
  isFavorited: boolean = false;
  isLogin: boolean = false;
  // price: number = 9.9;

  constructor(private route: ActivatedRoute, private moviesService: MoviesService,
    private authService: AuthenticationService, private userService: UserService, private router: Router) {
      this.authService.isLogin.subscribe(user => this.isLogin=user);
      this.route.paramMap.subscribe(
        p => {
          this.id = Number(p.get('id'))});
  }

  ngOnInit(): void {
    // get the id from the URL
    // read the id from UR: and go to MovieService, create getMovieDetails method => Observable<Movie>
    
        // console.log('Movie Id from the URL:' + this.id);
        // call the MovieService to get the movie info
        this.moviesService.getMovieDetails(this.id)
          .subscribe(
            m => {
              this.movie = m;
            }
          )
        this.checkIfIsPurchased();
        this.checkIfIsFavorited();
  }

  private checkIfIsPurchased() {
    if (this.isLogin) {
      this.userService.isPurchased(this.id).subscribe(r => {
        this.isPurchased = r;
      })
    }
  }

  private checkIfIsFavorited() {
    if (this.isLogin) {
      this.userService.isFavorited(this.id).subscribe(response => this.isFavorited=response);
    }
  }

  purchaseMovie(price:number) {
    this.userService.addPurchase(this.id, price).subscribe(data => {
      this.router.navigate(['user/purchases'])
    })
  }

  addFavorite(){
    this.userService.addFavorite(this.id).subscribe(data =>{
    this.refresh();

    });
  }
  removeFavorite(){
    this.userService.removeFavorite(this.id).subscribe(data => {
      this.refresh();
    });
  }

  private refresh()
  {
    window.location.reload();
  }
}
