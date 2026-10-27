import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as reverseArray } from '../02.ReverseAnArrayOfNumbers.js';

describe('02.ReverseAnArrayOfNumbers', () => {
    it('02 reverses the first n numbers', () => {
        expect(captureLog(() => reverseArray(3, [10, 20, 30, 40, 50]))).to.deep.equal(['30 20 10']);
    });
});
