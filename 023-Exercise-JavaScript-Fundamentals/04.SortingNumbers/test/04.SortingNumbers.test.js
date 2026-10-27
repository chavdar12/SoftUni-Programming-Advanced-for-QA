import { expect } from 'chai';
import { solve as sortingNumbers } from '../04.SortingNumbers.js';

describe('04.SortingNumbers', () => {
    it('04 alternates smallest and largest', () => {
        expect(sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]))
            .to.deep.equal([-3, 65, 1, 63, 3, 56, 18, 52, 31, 48]);
    });
});
