import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as multiply } from '../01.MultiplyTheNumberBy2.js';

describe('01.MultiplyTheNumberBy2', () => {
    it('01 multiplies the number by 2', () => {
        expect(captureLog(() => multiply(20))).to.deep.equal(['40']);
    });
});
