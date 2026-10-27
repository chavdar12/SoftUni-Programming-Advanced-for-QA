import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as city } from '../12.City.js';

describe('12.City', () => {
    it('12 prints every city property', () => {
        expect(captureLog(() => city({ name: 'Sofia', area: 492, population: 1238438 })))
            .to.deep.equal(['name -> Sofia', 'area -> 492', 'population -> 1238438']);
    });
});
