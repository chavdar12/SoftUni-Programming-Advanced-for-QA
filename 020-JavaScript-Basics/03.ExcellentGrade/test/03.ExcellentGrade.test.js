import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as excellentGrade } from '../03.ExcellentGrade.js';

describe('03.ExcellentGrade', () => {
    it('03 checks for an excellent grade', () => {
        expect(captureLog(() => excellentGrade(5.50))).to.deep.equal(['Excellent']);
        expect(captureLog(() => excellentGrade(4.35))).to.deep.equal(['Not excellent']);
    });
});
