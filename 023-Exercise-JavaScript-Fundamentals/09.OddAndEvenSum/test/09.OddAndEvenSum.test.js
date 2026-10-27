import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as oddAndEvenSum } from '../09.OddAndEvenSum.js';

describe('09.OddAndEvenSum', () => {
    it('09 sums odd and even digits', () => {
        expect(captureLog(() => oddAndEvenSum(1000435))).to.deep.equal(['Odd sum = 9, Even sum = 4']);
    });
});
