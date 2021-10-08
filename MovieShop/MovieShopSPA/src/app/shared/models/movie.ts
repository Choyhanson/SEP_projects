// Generated by https://quicktype.io

export interface Movie {
    movies:       MovieElement[];
    genres:       Genre[];
    rating:       number;
    casts:        Cast[];
    trailers:     Trailer[];
    trailer:      null;
    totalItemNum: number;
    currentPage:  number;
    genreId:      number;
}

export interface Cast {
    castId:      number;
    name:        string;
    tmdbUrl:     string;
    profilePath: string;
    movieId:     number;
    character:   string;
}

export interface Genre {
    movieId:        number;
    revenue:        null;
    genreId:        number;
    genreName:      string;
    movieTitle:     null;
    moviePosterUrl: null;
    pages:          number;
    rating:         null;
}

export interface MovieElement {
    id:               number;
    title:            string;
    overview:         string;
    tagline:          string;
    budget:           string;
    revenue:          string;
    imdbUrl:          string;
    tmdbUrl:          string;
    posterUrl:        string;
    backdropUrl:      string;
    originalLanguage: null;
    releaseDate:      null;
    runTime:          number;
    price:            number;
    createdDate:      string;
    updatedDate:      null;
    updatedBy:        null;
    createdBy:        null;
    rating:           null;
    year:             number;
    date:             string;
}

export interface Trailer {
    id:         number;
    trailerUrl: string;
    name:       string;
    movieId:    number;
}
