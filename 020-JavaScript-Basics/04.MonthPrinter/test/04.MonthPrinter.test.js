import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as monthPrinter } from '../04.MonthPrinter.js';

describe('04.MonthPrinter', () => {
    it('04 prints the month or Error!', () => {
        expect(captureLog(() => monthPrinter(2))).to.deep.equal(['February']);
        expect(captureLog(() => monthPrinter(13))).to.deep.equal(['Error!']);
    });
});
