import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as studentInfo } from '../02.StudentInformation.js';

describe('02.StudentInformation', () => {
    it('02 prints student info with the grade to two decimals', () => {
        expect(captureLog(() => studentInfo('John', 15, 5.54678))).to.deep.equal(['Name: John, Age: 15, Grade: 5.55']);
    });
});
