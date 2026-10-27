import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as printAndSum } from '../04.PrintAndSum.js';

describe('04.PrintAndSum', () => {
    it('04 prints a range and its sum', () => {
        expect(captureLog(() => printAndSum(5, 10))).to.deep.equal(['5 6 7 8 9 10', 'Sum: 45']);
    });
});
