<template>
  <div>
    <q-table
      class="q-ma-xl"
      title="Currency and Amount"
      :rows="currencyData"
      :columns="columns"
      row-key="currency"
      hide-bottom
    >
    </q-table>
  </div>
</template>

<script>
export default {
  data() {
    return {
      columns: [
        {
          name: "currency",
          align: "left",
          label: "Currency",
          field: "currency",
          sortable: true,
        },
        {
          name: "amount",
          align: "right",
          label: "Amount",
          field: "amount",
          sortable: true,
        },
      ],
      currencyData: [
        { currency: "AUD", amount: 1100.0 },
        { currency: "MYR", amount: 899.0 },
        { currency: "GBP", amount: 56000.0 },
        { currency: "EUR", amount: 5388.0 },
      ],
    };
  },
  methods: {},
};
</script>
