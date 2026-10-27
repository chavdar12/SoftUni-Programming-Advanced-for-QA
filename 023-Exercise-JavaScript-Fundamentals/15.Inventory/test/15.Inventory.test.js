import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as inventory } from '../15.Inventory.js';

describe('15.Inventory', () => {
    it('15 lists heroes sorted by level', () => {
        expect(captureLog(() => inventory([
            'Isacc / 25 / Apple, GravityGun',
            'Derek / 12 / BarrelVest, DestructionSword',
            'Hes / 1 / Desolator, Sentinel, Antara'
        ]))).to.deep.equal([
            'Hero: Hes', 'level => 1', 'items => Desolator, Sentinel, Antara',
            'Hero: Derek', 'level => 12', 'items => BarrelVest, DestructionSword',
            'Hero: Isacc', 'level => 25', 'items => Apple, GravityGun'
        ]);
    });
});
