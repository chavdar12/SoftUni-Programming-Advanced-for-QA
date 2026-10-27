import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as formatGrade } from '../07.FormatGrade.js';

describe('07.FormatGrade', () => {
    it('07 formats the grade with its description', () => {
        expect(captureLog(() => formatGrade(3.33))).to.deep.equal(['Poor (3.33)']);
        expect(captureLog(() => formatGrade(4.50))).to.deep.equal(['Very good (4.50)']);
        expect(captureLog(() => formatGrade(2.99))).to.deep.equal(['Fail (2)']);
    });
});
