import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as smallest } from '../07.SmallestOfThreeNums.js';

describe('07.SmallestOfThreeNums', () => {
    it('07 prints the smallest of three numbers', () => {
        expect(captureLog(() => smallest(2, 5, 3))).to.deep.equal(['2']);
    });
});
