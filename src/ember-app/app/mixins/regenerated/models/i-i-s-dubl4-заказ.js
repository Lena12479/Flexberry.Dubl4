import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  дата: DS.attr('date', { defaultValue() { return new Date(); } }),
  типОплаты: DS.attr('i-i-s-dubl4-оплата')
});

export let ValidationRules = {
  дата: {
    descriptionKey: 'models.i-i-s-dubl4-заказ.validations.дата.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  типОплаты: {
    descriptionKey: 'models.i-i-s-dubl4-заказ.validations.типОплаты.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ЗаказE', 'i-i-s-dubl4-заказ', {
    дата: attr('Дата', { index: 0 }),
    типОплаты: attr('Тип оплаты', { index: 1 })
  });

  modelClass.defineProjection('ЗаказL', 'i-i-s-dubl4-заказ', {
    дата: attr('Дата', { index: 0 }),
    типОплаты: attr('Тип оплаты', { index: 1 })
  });
};
