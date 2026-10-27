import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as movies } from '../14.Movies.js';

describe('14.Movies', () => {
    it('14 prints only movies with director and date, including multi-word titles', () => {
        expect(captureLog(() => movies([
            'addMovie Fast and Furious',
            'addMovie Godfather',
            'Inception directedBy Christopher Nolan',
            'Godfather directedBy Francis Ford Coppola',
            'Godfather onDate 29.07.2018',
            'Fast and Furious onDate 30.07.2018',
            'Batman onDate 01.08.2018',
            'Fast and Furious directedBy Rob Cohen'
        ]))).to.deep.equal([
            '{"name":"Fast and Furious","date":"30.07.2018","director":"Rob Cohen"}',
            '{"name":"Godfather","director":"Francis Ford Coppola","date":"29.07.2018"}'
        ]);
    });
});
