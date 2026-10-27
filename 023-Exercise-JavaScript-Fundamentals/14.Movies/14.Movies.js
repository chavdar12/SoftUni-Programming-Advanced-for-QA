export function solve(commands) {
    const movies = [];

    for (const command of commands) {
        if (command.startsWith('addMovie ')) {
            movies.push({ name: command.substring('addMovie '.length) });
        }
        else if (command.includes(' directedBy ')) {
            const [name, director] = command.split(' directedBy ');
            const movie = movies.find(m => m.name === name);
            if (movie) {
                movie.director = director;
            }
        }
        else if (command.includes(' onDate ')) {
            const [name, date] = command.split(' onDate ');
            const movie = movies.find(m => m.name === name);
            if (movie) {
                movie.date = date;
            }
        }
    }

    movies
        .filter(movie => movie.director && movie.date)
        .forEach(movie => console.log(JSON.stringify(movie)));
}
