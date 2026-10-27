import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as largestNumber } from '../06.LargestNumber.js';

describe('06.LargestNumber', () => {
    it('06 finds the largest of three numbers', () => {
        expect(captureLog(() => largestNumber(5, -3, 16))).to.deep.equal(['The largest number is 16.']);
        expect(captureLog(() => largestNumber(-3, -5, -22.5))).to.deep.equal(['The largest number is -3.']);
    });
});
