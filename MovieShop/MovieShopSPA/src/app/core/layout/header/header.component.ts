import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { GenreElement,Genre } from 'src/app/shared/models/genre';
import { User } from 'src/app/shared/models/user';
import { AuthenticationService } from '../../services/authentication.service';
import { GenreService } from '../../services/genre.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})

export class HeaderComponent implements OnInit {

  @Input() genres!:Genre;
  @Input() genreMenu!:GenreElement[];

  user!:User;
  isLogin:boolean=false;

  constructor(private genreService: GenreService,private authService:AuthenticationService,
     private router: Router) 
  { 
    this.authService.currentUser.subscribe( m=>this.user=m );
    this.authService.isLogin.subscribe( m => this.isLogin=m);
  }

  ngOnInit(): void {
    this.genreService.getAllGenres().subscribe(
      g => {
        this.genreMenu = g;
      }
    )
  }

  logout(){
    this.authService.logout();
    this.router.navigateByUrl('account/login');
  }
}
