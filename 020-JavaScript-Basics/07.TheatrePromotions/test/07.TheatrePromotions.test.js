import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as theatrePromotions } from '../07.TheatrePromotions.js';

describe('07.TheatrePromotions', () => {
    it('07 prices theatre tickets by day and age', () => {
        expect(captureLog(() => theatrePromotions('Weekday', 42))).to.deep.equal(['18$']);
        expect(captureLog(() => theatrePromotions('Holiday', 15))).to.deep.equal(['5$']);
        expect(captureLog(() => theatrePromotions('Weekend', 65))).to.deep.equal(['15$']);
        expect(captureLog(() => theatrePromotions('Holiday', -12))).to.deep.equal(['Error!']);
    });
});
