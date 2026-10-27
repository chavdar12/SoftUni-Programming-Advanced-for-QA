import { expect } from 'chai';
import { solve as everyNth } from '../02.PrintEveryN-thElementFromAnArray.js';

describe('02.PrintEveryN-thElementFromAnArray', () => {
    it('02 takes every n-th element without running past the end', () => {
        expect(everyNth(['5', '20', '31', '4', '20'], 2)).to.deep.equal(['5', '31', '20']);
        expect(everyNth(['dsa', 'asd', 'test', 'tset'], 2)).to.deep.equal(['dsa', 'test']);
    });
});
