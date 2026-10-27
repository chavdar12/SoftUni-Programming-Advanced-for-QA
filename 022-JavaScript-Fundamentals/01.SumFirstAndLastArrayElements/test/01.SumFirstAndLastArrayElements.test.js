import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as sumFirstAndLast } from '../01.SumFirstAndLastArrayElements.js';

describe('01.SumFirstAndLastArrayElements', () => {
    it('01 sums the first and last elements', () => {
        expect(captureLog(() => sumFirstAndLast([10, 17, 22, 33]))).to.deep.equal(['43']);
    });
});
